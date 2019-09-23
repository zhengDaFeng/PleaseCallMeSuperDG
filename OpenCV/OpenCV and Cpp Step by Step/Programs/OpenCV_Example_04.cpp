/*
作者：郑大峰
时间：2019年09月20日
环境：OpenCV 4.1.1 + VS2017
内容：Change Brightness
*/

#include "pch.h"
#include <iostream>
#include <opencv2/opencv.hpp>

using namespace std;
using namespace cv;

int main()
{
	Mat image = imread("claudia.png");

	if (image.empty())
	{
		cout << "Could not open or find the image" << endl;
		cin.get();
		return -1;
	}

	Mat imageBrighnessHigh50;
	image.convertTo(imageBrighnessHigh50, -1, 1, 50); //increase the brightness by 50

	Mat imageBrighnessHigh100;
	image.convertTo(imageBrighnessHigh100, -1, 1, 100); //increase the brightness by 100

	Mat imageBrighnessLow50;
	image.convertTo(imageBrighnessLow50, -1, 1, -50); //decrease the brightness by 50

	Mat imageBrighnessLow100;
	image.convertTo(imageBrighnessLow100, -1, 1, -100); //decrease the brightness by 100

	//Defining window names for above images
	String windowNameOriginalImage = "Original Image";
	String windowNameBrightnessHigh50 = "Brightness Increased by 50";
	String windowNameWithBrightnessHigh100 = "Brightness Increased by 100";
	String windowNameBrightnessLow50 = "Brightness Decreased by 50";
	String windowNameBrightnessLow100 = "Brightness Decreased by 100";

	//Create and open windows for above images
	namedWindow(windowNameOriginalImage, WINDOW_NORMAL);
	namedWindow(windowNameBrightnessHigh50, WINDOW_NORMAL);
	namedWindow(windowNameWithBrightnessHigh100, WINDOW_NORMAL);
	namedWindow(windowNameBrightnessLow50, WINDOW_NORMAL);
	namedWindow(windowNameBrightnessLow100, WINDOW_NORMAL);

	//Show above images inside the created windows.
	imshow(windowNameOriginalImage, image);
	imshow(windowNameBrightnessHigh50, imageBrighnessHigh50);
	imshow(windowNameWithBrightnessHigh100, imageBrighnessHigh100);
	imshow(windowNameBrightnessLow50, imageBrighnessLow50);
	imshow(windowNameBrightnessLow100, imageBrighnessLow100);

	waitKey(0); // Wait for any key stroke

	destroyAllWindows(); //destroy all open windows

	return 0;
}