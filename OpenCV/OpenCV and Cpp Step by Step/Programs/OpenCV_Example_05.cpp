/*
作者：郑大峰
时间：2019年09月20日
环境：OpenCV 4.1.1 + VS2017
内容：Change Contrast
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

	Mat imageContrastHigh2;
	image.convertTo(imageContrastHigh2, -1, 2, 0); //increase the contrast by 2

	Mat imageContrastHigh4;
	image.convertTo(imageContrastHigh4, -1, 4, 0); //increase the contrast by 4

	Mat imageContrastLow0_5;
	image.convertTo(imageContrastLow0_5, -1, 0.5, 0); //decrease the contrast by 0.5

	Mat imageContrastLow0_25;
	image.convertTo(imageContrastLow0_25, -1, 0.25, 0); //decrease the contrast by 0.25


	//Defining window names for above images
	String windowNameOriginalImage = "Original Image";
	String windowNameContrastHigh2 = "Contrast Increased by 2";
	String windowNameContrastHigh4 = "Contrast Increased by 4";
	String windowNameContrastLow0_5 = "Contrast Decreased by 0.5";
	String windowNameContrastLow0_25 = "Contrast Decreased by 0.25";

	//Create and open windows for above images
	namedWindow(windowNameOriginalImage, WINDOW_NORMAL);
	namedWindow(windowNameContrastHigh2, WINDOW_NORMAL);
	namedWindow(windowNameContrastHigh4, WINDOW_NORMAL);
	namedWindow(windowNameContrastLow0_5, WINDOW_NORMAL);
	namedWindow(windowNameContrastLow0_25, WINDOW_NORMAL);

	//Show above images inside the created windows.
	imshow(windowNameOriginalImage, image);
	imshow(windowNameContrastHigh2, imageContrastHigh2);
	imshow(windowNameContrastHigh4, imageContrastHigh4);
	imshow(windowNameContrastLow0_5, imageContrastLow0_5);
	imshow(windowNameContrastLow0_25, imageContrastLow0_25);

	waitKey(0); // Wait for any key stroke

	destroyAllWindows(); //destroy all open windows

	return 0;
}