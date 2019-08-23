二维仿射变换，顾名思义就是在二维平面内，对对象进行**平移、旋转、缩放**等变换的行为（当然还有其他的变换，这里仅论述这三种最常见的）。

Halcon中进行仿射变换的常见步骤如下：

① 通过**hom_mat2d_identity**算子创建一个**初始化矩阵**（即**[1.0, 0.0, 0.0, 0.0, 1.0, 0.0]**）；

② 在初始化矩阵的基础上，使用**hom_mat2d_translate（平移）、hom_mat2d_rotate（旋转）、hom_mat2d_scale（缩放）**等生成仿射变换矩阵；（这几个算子**可以叠加或者重复使用**）

③ 根据生成的变换矩阵执行仿射变换，执行仿射变换的算子通常有：**affine_trans_image、affine_trans_region、affine_trans_contour_xld**，即不管对于**图像、区域、XLD**都可以执行仿射变换。

下面用一个完整程序分别展示hom_mat2d_translate（平移）、hom_mat2d_rotate（旋转）、hom_mat2d_scale（缩放）这三个算子的的具体功能。（特别要注意程序注释部分）

**hom_mat2d_translate( : : HomMat2D,  Tx, Ty  : HomMat2DTranslate)**

**hom_mat2d_rotate( : : HomMat2D,  Phi, Px, Py  : HomMat2DRotate)**

**hom_mat2d_scale( : : HomMat2D,  Sx, Sy, Px, Py  : HomMat2DScale)**

```
read_image (Image, 'hogn-1.jpg')
threshold (Image, Region, 0, 200)
opening_circle (Region, Region, 1.5)
connection (Region, ConnectedRegions)
select_shape_std (ConnectedRegions, SelectedRegions, 'max_area', 70)
*得到变换的中心点
area_center (SelectedRegions, Area, Row, Column)
dev_set_draw ('margin')

*hom_mat2d_translate中的两个参数的意思是：Tx和Ty分别代表Row方向和Column方向的平移量
dev_display (Image)
disp_cross (3600, Row, Column, 10, 40)
hom_mat2d_identity (HomMat2DIdentity)
hom_mat2d_translate (HomMat2DIdentity,30, 150, HomMat2DTranslate)
affine_trans_region (Region, RegionAffineTrans, HomMat2DTranslate, 'nearest_neighbor')

*hom_mat2d_rotate中的三个参数的意思是：旋转角度（逆时针为正，弧度制），旋转中心的row和column值
dev_display (Image)
disp_cross (3600, Row, Column, 10, 40)
hom_mat2d_rotate (HomMat2DIdentity, rad(20), Row, Column, HomMat2DRotate)
affine_trans_region (Region, RegionAffineTrans, HomMat2DRotate, 'nearest_neighbor')

*hom_mat2d_scale中的四个参数的意思是：Sx和Sy分别代表Row方向和Column方向的缩放系数，缩放中心的row和column值
dev_display (Image)
disp_cross (3600, Row, Column, 10, 40)
hom_mat2d_scale (HomMat2DIdentity, 2.0, 1.05, Row, Column, HomMat2DScale)
affine_trans_region (Region, RegionAffineTrans, HomMat2DScale, 'nearest_neighbor')
```

有时候，并不需要创建**初始化矩阵**也可以执行仿射变换，例如vector_angle_to_rigid算子就是如此。

**vector_angle_to_rigid( : : Row1, Column1, Angle1, Row2, Column2, Angle2  : HomMat2D)**

该算子意思是：先将图像旋转，旋转角度为(Angle2 - Angle1) （逆时针为正）,**旋转中心坐标是(Row1, Column1)**。再将原图的点(Row1, Column1)一一对应移到点 (Row2, Column2)上，移动的row和column方向的位移分别是( Row2 - Row1)、( Column2 - Column1),  
  

如果**Row1 = Row2, Column1 = Column2**，那么就完整等价于旋转变换。可以执行下面的程序感受一下：

```
read_image (Image, 'hogn-1.jpg')
Row := 100
Column := 200
dev_display (Image)


for Index := 1 to 150 by 1  
    vector_angle_to_rigid (Row, Column, 0, Row, Column, rad(10), HomMat2D)
    disp_cross (3600, 100, 200, 10, 40)
    affine_trans_image (Image, ImageAffinTrans, HomMat2D, 'nearest_neighbor', 'false')
    copy_image (ImageAffinTrans, Image) 
endfor
```

可以将**vector_angle_to_rigid**理解为**同时执行旋转变换和平移变换**。最难弄明白的是旋转中心是什么？下面的程序可以说明如果**先旋转后平移**，那么**旋转中心是(Row1, Column1)**，而不是 (Row2, Column2)。（如果先平移后旋转，那么结论刚好相反，大家可以试试）

```
read_image (Image, 'hogn-1.jpg')
Row1 := 100
Column1 := 100

Row2 := 100
Column2 := 200
dev_display (Image)
*用vector_angle_to_rigid实现缩放、平移
vector_angle_to_rigid (Row1, Column1, 0, Row2, Column2, rad(10), HomMat2D)
affine_trans_image (Image, ImageAffinTrans, HomMat2D, 'nearest_neighbor', 'false')

*分两步依次执行缩放、平移
hom_mat2d_identity (HomMat2DIdentity)
hom_mat2d_rotate (HomMat2DIdentity, rad(10) - 0, Row1, Column1, HomMat2DRotate)
hom_mat2d_translate (HomMat2DRotate,Row2 - Row1, Column2 - Column1, HomMat2DTranslate)
*观察图像ImageAffinTrans和ImageAffinTrans_2能够完全重合
affine_trans_image (Image, ImageAffinTrans_2, HomMat2DTranslate, 'nearest_neighbor', 'false')

disp_cross (3600, Row1, Column1, 10, 40)
```

vector_angle_to_rigid最常用到的场合一般是模板匹配之类的算法场合，通常用在**find_shape_model**等算子后面。
