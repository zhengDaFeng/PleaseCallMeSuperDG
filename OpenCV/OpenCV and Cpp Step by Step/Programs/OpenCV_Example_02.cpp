/*
作者：郑大峰
时间：2019年09月20日
环境：OpenCV 4.1.1 + VS2017
内容：Create a Blank Image & Display
*/

#include "pch.h"
#include <iostream>
#include <opencv2/opencv.hpp>

using namespace std;
using namespace cv;

int main()
{
	// Create a new image which consists of 
	// 800 x 600 of resolution (800 wide and 600 high)
	// image depth of 8 bits & 3 channels 
	// each pixels initialized to the value of (100, 250, 30) for Blue, Green and Red planes respectively
	Mat image(600, 800, CV_8UC3, Scalar(100, 250, 30));

	String windowName = "Window with Blank Image";
	namedWindow(windowName);
	imshow(windowName, image);

	waitKey(0);
	destroyWindow(windowName);

	return 0;
}