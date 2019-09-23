/*
作者：郑大峰
时间：2019年09月23日
环境：OpenCV 4.1.1 + VS2017
内容：Invert Images
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

	//inverted method 1
	Mat image_inverted;
	image_inverted = ~image;

	//inverted method 2
	Mat image_inverted2;
	image_inverted2 = Scalar(255, 255, 255) - image;

	//create the window
	namedWindow("claudia.png", WINDOW_AUTOSIZE);
	namedWindow("claudia_inverted.png", WINDOW_AUTOSIZE);
	namedWindow("claudia_inverted2.png", WINDOW_AUTOSIZE);

	//show the inverted image
	imshow("claudia.png", image);
	imshow("claudia_inverted.png", image_inverted);
	imshow("claudia_inverted2.png", image_inverted);

	waitKey(0); // Wait for any key stroke

	destroyAllWindows(); //destroy all open windows

	return 0;
}