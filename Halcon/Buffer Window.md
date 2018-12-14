# 缓冲窗口的应用

 - 与 dump_window 这条算子配合，以图片原始大小的尺寸截取窗口。
 - 与 copy_rectangle 这条算子配合，规避显示闪烁问题
~~~
* 准备阶段：打开一个不可见的缓冲窗口
open_window（0,0，Width，Height，0，'buffer'，“，BufferWindow）

* 运行阶段：将内容绘制在这个窗口上
******

* 应用一：截取这个缓冲窗口的图像
dump_window（BufferWindow，'png'，'Result.png'）
* 应用二：将缓冲窗口的内容复制到可见的窗口上
copy_rectangle（BufferWindow，VisibleWindow，0,0，Width-1，Height-1,0,0）
~~~

