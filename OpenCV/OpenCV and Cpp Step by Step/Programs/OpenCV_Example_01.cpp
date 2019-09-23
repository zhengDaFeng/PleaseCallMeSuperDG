/*
作者：郑大峰
时间：2019年09月19日
环境：OpenCV 4.1.1 + VS2017
内容：Load Image from File and Display
*/

#include "pch.h" // 这个是预编译头文件，VS2017之前的版本为stdafx.h，详细请自行搜索
#include <iostream>
#include <opencv2/opencv.hpp> // 包含OpenCV库的头文件

using namespace std;
using namespace cv; // OpenCV中所有的类、函数和数据结构都在该命名空间下定义

int main()
{
	// 相对路径注意事项
	// 1）图片放在代码文件同级目录下，启动调试可正常读取图像。但是双击生成的可执行文件，则读取不到图像。
	// 2）复制图像至生成的可执行文件同级目录下，双击可执行文件，可正常读取图像
	string image_file = "claudia.png";

	// 如果同时添加Debug或者Release对应的依赖，这里会读取不到图像
	Mat img = imread(image_file, IMREAD_UNCHANGED);
	// If imread() function fails to load the image, the returned Mat object will be empty. 
	// If the Mat object is empty, image.empty() function will return true.
	if (img.empty())
	{
		cout << "Image is empty!";
		return -1;
	}

	namedWindow(image_file, WINDOW_AUTOSIZE); // Create a window
	imshow(image_file, img); // Show our image inside the created window.

	waitKey(0); // 一直等待按键输入。当按键被点击时，返回点击按键的ASCII码

	return 0;
}