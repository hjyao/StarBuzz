github new start 2 开始： 
bad smell: 很多if，divergent change；
guard clauses
replace conditional with polymorphism =>replace type code with subclass =>self Encapsulate Field 如果有类型码被传递给构造函数，就需要将构造函数换成factory 方法：建个新的子类，继承父类，将类型码方法copy过去，构建constructor，修改factory方法逻辑，创建新类；将所有分支都变成子类，修改原有constructor（espresso的，即移除所有参数）；将factory方法里的if()if()if()=>if()else{}格式，inline factory 方法，调整测试，并移除类中无用field，method；

目前为止：出来了三个with..类，继承自espresso；
bad smell:1.  nightmare maintenance when adding new condiment => class explosion 
2.milk price raise => class related change(espressoWithMilk and darkrosestWithMilk ….)=> shotgun

favor    :     composition over inheritance
solution: replace inheritance with delegation 
	修改测试，将Espresso对象传入with类，修改构造函数，接收espresso，并用espresso替换原有的base属性，打破继承；

目前为止： 三个with类 ，不与任何类有继承关系；
bad smell：duplicate code
solution：Extract superclass => Condiment
在任意with类中的cost方法上抽取父类，并将父类的cost声明为abstract ，父类也是abstract；
这样就与beverage无差异，直接继承自beverage，删除condiment；

目前为止：三个with类，直接继承自beverage
bad smell：withSugarAndMilk 与 milk 和 sugar 有duplicate code；
solution：将milk和sugar的 constructor中的 参数类型 use base type where possible 替换成 beverage；

然后修改测试将用到withSugarAndMilk的 换成Sugar(new Milk(new Espresso))；删除withSugarAndMilk 即可；
