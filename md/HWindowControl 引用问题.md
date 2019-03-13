# 操作

新建**类库项目**，添加 HalconDotNet 引用，使用 HWindowControl 定义变量。

# 运行环境1

- 系统 - Windows 10
- Halcon版本 - 12.0.0
- vs版本 - 2017

编译运行，无任何错误。

# 运行环境2

- 系统 - Windows 10
- Halcon版本 - 12.0.0
- vs版本 - 2010/2013

## 编译错误

> 类型“System.Windows.Forms.UserControl”在未被引用的程序集中定义，必须添加对程序集"类型“System.Windows.Forms, Version=2.0.0.0..."的引用

## 解决方式

添加 **System.Windows.Forms** 该引用后编译通过。

# 解析

这里算不上解析吧，网上也难以找到相关说明，纯属个人推测。HWindowControl这个控件应该是Halcon官方使用 System.Windows.Forms.UserControl 进行定义的，封装成DLL后，由于vs2010和vs2013的编译器不够智能，或者是编译器bug，所以编译出错了。vs2017对编译器进行了改进，识别出了该控件及其引用，或者说修复了这个bug。