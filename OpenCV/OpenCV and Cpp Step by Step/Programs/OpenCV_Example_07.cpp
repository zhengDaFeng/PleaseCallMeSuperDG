/*
作者：郑大峰
时间：2019年09月20日
环境：OpenCV 4.1.1 + VS2017
内容：Histogram Equalization of a Color image with OpenCV
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

	//Convert the image from BGR to YCrCb color space
	Mat hist_equalized_image;
	cvtColor(image, hist_equalized_image, COLOR_BGR2YCrCb);

	//Split the image into 3 channels; Y, Cr and Cb channels respectively and store it in a std::vector
	vector<Mat> vec_channels;
	split(hist_equalized_image, vec_channels);

	//Equalize the histogram of only the Y channel 
	equalizeHist(vec_channels[0], vec_channels[0]);

	//Merge 3 channels in the vector to form the color image in YCrCB color space.
	merge(vec_channels, hist_equalized_image);

	//Convert the histogram equalized image from YCrCb to BGR color space again
	cvtColor(hist_equalized_image, hist_equalized_image, COLOR_YCrCb2BGR);

	//Define the names of windows
	String windowNameOfOriginalImage = "Original Image";
	String windowNameOfHistogramEqualized = "Histogram Equalized Color Image";

	// Create windows with the above names
	namedWindow(windowNameOfOriginalImage, WINDOW_NORMAL);
	namedWindow(windowNameOfHistogramEqualized, WINDOW_NORMAL);

	// Show images inside the created windows.
	imshow(windowNameOfOriginalImage, image);
	imshow(windowNameOfHistogramEqualized, hist_equalized_image);

	waitKey(0); // Wait for any key stroke

	destroyAllWindows(); //destroy all open windows

	return 0;
}