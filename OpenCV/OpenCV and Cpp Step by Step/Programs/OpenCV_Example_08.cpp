/*
作者：郑大峰
时间：2019年09月23日
环境：OpenCV 4.1.1 + VS2017
内容：Homogeneous Blur on Images with OpenCV
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

	//Blur the image with 3x3 kernel
	Mat image_blurred_with_3x3_kernel;
	blur(image, image_blurred_with_3x3_kernel, Size(3, 3));

	//Blur the image with 5x5 kernel
	Mat image_blurred_with_5x5_kernel;
	blur(image, image_blurred_with_5x5_kernel, Size(5, 5));

	//Define names of the windows
	String window_name = "claudia.png";
	String window_name_blurred_with_3x3_kernel = "claudia.png Blurred with 3 x 3 Kernel";
	String window_name_blurred_with_5x5_kernel = "claudia.png Blurred with 5 x 5 Kernel";

	// Create windows with above names
	namedWindow(window_name);
	namedWindow(window_name_blurred_with_3x3_kernel);
	namedWindow(window_name_blurred_with_5x5_kernel);

	// Show our images inside the created windows.
	imshow(window_name, image);
	imshow(window_name_blurred_with_3x3_kernel, image_blurred_with_3x3_kernel);
	imshow(window_name_blurred_with_5x5_kernel, image_blurred_with_5x5_kernel);

	waitKey(0); // Wait for any key stroke

	destroyAllWindows(); //destroy all open windows

	return 0;
}