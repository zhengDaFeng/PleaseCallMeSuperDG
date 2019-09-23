/*
作者：郑大峰
时间：2019年09月20日
环境：OpenCV 4.1.1 + VS2017
内容：Save an Image to a File
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

	/*
	Make changes to the image as necessary
	e.g.
	 1. Change brightness/contrast of the image
	 2. Smooth/Blur image
	 3. Crop the image
	 4. Rotate the image
	 5. Draw shapes on the image
	*/

	//bool isSuccess = imwrite("claudia_changed.jpg", image); //write the image to a file as JPEG 
	bool isSuccess = imwrite("claudia_changed.png", image); //write the image to a file as PNG
	if (isSuccess == false)
	{
		cout << "Failed to save the image" << endl;
		cin.get();
		return -1;
	}

	cout << "Image is succusfully saved to a file" << endl;
	cin.get();

	return 0;
}