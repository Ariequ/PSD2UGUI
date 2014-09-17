Unity在4.6版本中将要发布新的UI系统UGUI, 关于UGUI的介绍,请查看Overview of the New UI System。

一般来说，游戏UI的制作步骤为:  
1. 美术在设计软件（PhotoShop，Flash）中进行UI的设计.  
2. 美术导出切分好的散图和整体效果图。  
3. 程序在程序的开发环境中参照效果图实现UI的布局和功能。  
这种工作流就经常导致程序制作出的UI效果和美术的设计存在偏差，并且对于美术的修改来说也不够友好。

使用Unity开发UI，理想的情况是美术也能够使用Untity进行设计和实现。但现实往往是美术不太接受使用不太熟悉的软件进行创作。并且美术如果和程序公用同一项目，在版本维护中出错的机会也比较大。

不同系统之间的集成通常都是通过中间语言的传递来实现的。参考A good workflow to smoothly import 2D content into Unity:

本文给出的“从PSD UI制作到Unity UGUI生成的工作流”是：  
1. 从PSD中导出可以描述UI的配置和对应的图片资源。  
2. 使用Unity读取配置，使用图片资源生成对应的UI.  
其中，PSD中的”组”与”层”的组织和命名需要遵循一定的规范。组织规范定义了UI的结构，命名规范定义了UI的组件类型（包括：Button、Label、Image、ScrollView、ListView等）和参数。从Photoshop导出对应配置是使用Photoshop支持的ExtendScript，通过遍历PSD，生成UI的结构并使用XML保存，同时也会导出相应的图片资源。

PSD预览与对应的层级结构
![预览图](http://ariequ.github.io/images/0916_2.png)

资源复用问题

通过包含特殊字段的命名（如：Common），可以指定某些图片引用自其他的PSD文件，这样当Unity导入的时候就可以根据命名去查找对应的图片资源，从而保证相同的图片资源在Unity的资源中仅存在一份。

Sprite Packer使用

UI资源图片在导入的时候通过设置类型为Sprite，然后通过指定Packing Tag，可以将相同的Packing Tag的图片在Build时打包到同一个图片集，从而降低DrawCall.

参考资料:
1. A good workflow to smoothly import 2D content into Unity
