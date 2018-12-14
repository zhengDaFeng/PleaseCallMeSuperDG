# 保存数据至CSV文件

~~~
open_file ('data.csv', 'append', FileHandle)

***图像处理，获得结果***

* 同一行间使用“,”将数据分割成不同列
fwrite_string (FileHandle, 'X=' + Column + ',' + 'Y=' + Row)
* 下一行
fnew_line (FileHandle)

close_file (FileHandle)
~~~
