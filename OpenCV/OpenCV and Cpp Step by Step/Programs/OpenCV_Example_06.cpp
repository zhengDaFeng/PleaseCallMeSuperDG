/*
作者：郑大峰
时间：2019年09月20日
环境：OpenCV 4.1.1 + VS2017
内容：Histogram Equalization
*/

#include "pch.h"
#include <iostream>
#include <opencv2/opencv.hpp>

using namespace std;
using namespace cv;

// 得到图像的直方图
MatND getHistogram(Mat &image)
{
	MatND hist;
	int channels[] = { 0 };
	int dims = 1;
	int histSize[] = { 256 };
	float granges[] = { 0, 255 };
	const float *ranges[] = { granges };
	calcHist(&image, 1, channels, Mat(), hist, dims, histSize, ranges);
	return hist;
}
//  将图像直方图展示出来  
Mat getHistogramImage(Mat &image)
{
	MatND hist = getHistogram(image);
	Mat showImage(256, 256, CV_8U, Scalar(0));
	int i;
	double maxValue = 0;
	minMaxLoc(hist, 0, &maxValue, 0, 0);
	for (i = 0; i < 256; i++)
	{
		float value = hist.at<float>(i);
		int intensity = saturate_cast<int>(256 - 256 * (value / maxValue));
		rectangle(showImage, Point(i, 256 - 1), Point((i + 1) - 1, intensity), Scalar(255));
	}
	return showImage;
}

int main()
{
	Mat image = imread("Unequalized_Hawkes_Bay_NZ.jpg");

	if (image.empty())
	{
		cout << "Could not open or find the image" << endl;
		cin.get();
		return -1;
	}

	//change the color image to grayscale image
	cvtColor(image, image, COLOR_BGR2GRAY);

	Mat histogramImageSrc = getHistogramImage(image);
	imshow("Src image histogram", histogramImageSrc);

	//equalize the histogram
	Mat hist_equalized_image;
	equalizeHist(image, hist_equalized_image);

	Mat histogramImageDst = getHistogramImage(hist_equalized_image);
	imshow("Dst image histogram", histogramImageDst);

	//Define names of windows
	String windowNameOfOriginalImage = "Original Image";
	String windowNameOfHistogramEqualized = "Histogram Equalized Image";

	// Create windows with the above names
	namedWindow(windowNameOfOriginalImage, WINDOW_NORMAL);
	namedWindow(windowNameOfHistogramEqualized, WINDOW_NORMAL);

	// Show images inside created windows.
	imshow(windowNameOfOriginalImage, image);
	imshow(windowNameOfHistogramEqualized, hist_equalized_image);

	waitKey(0); // Wait for any key stroke

	destroyAllWindows(); //destroy all open windows

	return 0;
}