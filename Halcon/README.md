# Halcon

This is the note I wrote down when I was learning halcon.

## Table of Contents

- [Calibration](https://github.com/zhengDaFeng/PleaseCallMeSuperDG/tree/master/Halcon#calibration)

## Reference

[HALCON Operator Reference - Version 18.05](https://www.mvtec.com/doc/halcon/1805/en/ "HALCON Operator Reference - Version 18.05")

## Calibration

### Preparing the calibration input data

- **[create_calib_data](https://www.mvtec.com/doc/halcon/1805/en/create_calib_data.html "create_calib_data")** - Specifying the number of cameras in the setup and the number of used calibration objects.
- **[set_calib_data_cam_param](https://www.mvtec.com/doc/halcon/1805/en/set_calib_data_cam_param.html "set_calib_data_cam_param")** - Specify the camera type and the initial internal camera parameters for all cameras.
- **[set_calib_data_calib_object](https://www.mvtec.com/doc/halcon/1805/en/set_calib_data_calib_object.html "set_calib_data_calib_object")** - Specify the description of all calibration objects.
- **[set_calib_data_observ_points](https://www.mvtec.com/doc/halcon/1805/en/set_calib_data_observ_points.html "set_calib_data_observ_points")** - Set point-based observation data in a calibration data model.
- **[find_calib_object](https://www.mvtec.com/doc/halcon/1805/en/find_calib_object.html "find_calib_object")** - The image coordinates of the extracted calibration marks of the calibration object and a roughly estimated pose of the calibration object relative to the observing camera.
- **[get_calib_data_observ_points](https://www.mvtec.com/doc/halcon/1805/en/get_calib_data_observ_points.html "get_calib_data_observ_points")** - Query the extracted points.
- **[get_calib_data_observ_contours](https://www.mvtec.com/doc/halcon/1805/en/get_calib_data_observ_contours.html "get_calib_data_observ_contours")** - Query the extracted contours.
- **[set_calib_data](https://www.mvtec.com/doc/halcon/1805/en/set_calib_data.html "set_calib_data")** - Specify the reference camera or exclude certain internal or external camera parameters from the optimization. 

### Performing the actual camera calibration

- **[calibrate_cameras](https://www.mvtec.com/doc/halcon/1805/en/calibrate_cameras.html "calibrate_cameras")** - Calculates the internal and external camera parameters of a calibration data model.

### Checking the success of the calibration

If only a single camera is calibrated, an Error in the order of 0.1 pixel (the typical detection error by extraction of the coordinates of the projected calibration markers) is an indication that the optimization fits the observation data well. If Error strongly differs from 0.1 pixels, the calibration did not perform well. 
 If more than one camera is calibrated simultaneously, the value of Error is more difficult to judge. As a rule of thumb, Error should be as small as possible and at least smaller than 1.0, thus indicating that a subpixel precise evaluation of the data is possible with the calibrated parameters. 

### Getting the calibration results

- **[get_calib_data](https://www.mvtec.com/doc/halcon/1805/en/get_calib_data.html "get_calib_data")** - Query the results of the calibration, i.e., internal camera parameters, camera poses (external camera parameters), calibration objects poses etc..

### End of calibration

- **[write_cam_par](https://www.mvtec.com/doc/halcon/1805/en/write_cam_par.html "write_cam_par")** - Write the internal camera parameters to a text file.
- **[clear_calib_data](https://www.mvtec.com/doc/halcon/1805/en/clear_calib_data.html "clear_calib_data")** - Free the memory of a calibration data model.

### Start Rectification

- **[read_cam_par](https://www.mvtec.com/doc/halcon/1805/en/read_cam_par.html "read_cam_par")** - Read internal camera parameters from a file.
- **[gen_radial_distortion_map](https://www.mvtec.com/doc/halcon/1805/en/gen_radial_distortion_map.html "gen_radial_distortion_map")** - Generate a projection map that describes the mapping of images corresponding to a changing radial distortion.
- **[map_image](https://www.mvtec.com/doc/halcon/1805/en/map_image.html "map_image")** - Apply a general transformation to an image.

### Camera parameters

#### Internal camera parameters

- **area_scan_division** - [Focus, Kappa, Sx, Sy, Cx, Cy, ImageWidth, ImageHeight]
- **line_scan** - [Focus, Kappa, Sx, Sy, Cx, Cy, ImageWidth, ImageHeight, Vx, Vy, Vz]

**Focus** - Focal length of the lens. 0 for telecentric lenses.  
**Kappa** - Distortion coefficient to model the radial lens distortions (only for division model).  
**Sx, Sy** - Scale factors. For pinhole cameras, this corresponds to the horizontal and vertical distance between two neighboring cells on the sensor. For telecentric cameras, this represents the horizontal and vertical size of a pixel in world coordinates (i.e., the distance of the cells on the sensor divided by the magnification of the lens).  
**Cx, Cy** - Column () and row () coordinate of the principal point of the image (center of the radial distortion).  
**ImageWidth, Image Height** - Width and height of the sampled image. Attention: These values decrease if the image is subsampled!  
**Vx, Vy, Vz** - X, Y, and Z-component of the motion vector.  

#### External camera parameters

**TransX**: Translation along the x-axis of the camera coordinate system.  
**TransY**: Translation along the y-axis of the camera coordinate system.  
**TransZ**: Translation along the z-axis of the camera coordinate system.  
**RotX**: Rotation around the x-axis of the camera coordinate system.  
**RotY**: Rotation around the y-axis of the camera coordinate system.  
**RotZ**: Rotation around the z-axis of the camera coordinate system.  

