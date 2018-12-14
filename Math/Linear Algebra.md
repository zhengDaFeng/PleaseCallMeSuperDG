# 线性代数（Linear Algebra）

辅助网站：

[在线 LaTeX 编辑器](https://link.jianshu.com/?t=https://www.codecogs.com/latex/eqneditor.php)

[斯坦福大学线性代数 - 翻译](https://blog.csdn.net/longxinchen_ml/article/details/51629328)

代码块中的 LaTeX 语句貌似没有效果，找了好久才找到这种在md文件中使用数学符号的方法，但是毕竟是基于这个网站的，总感觉很虚，以后再找一歌更好的办法吧。

一天学一些，水滴石穿。

## 1. 基本符号

<img src="https://latex.codecogs.com/png.latex?A&space;\epsilon&space;R_{m*n}" title="A \epsilon R_{m*n}" /> ：表示一个m行n列的矩阵，其中的所有元素均为实数。

<img src="https://latex.codecogs.com/png.latex?X&space;\epsilon&space;R^{n}" title="X \epsilon R^{n}" />：表示一个n个元素的列向量。

<center><img src="https://latex.codecogs.com/png.latex?\begin{bmatrix}&space;x_{1}\\&space;x_{2}\\&space;...\\&space;x_{n}&space;\end{bmatrix}" title="\begin{bmatrix} x_{1}\\ x_{2}\\ ...\\ x_{n} \end{bmatrix}" /></center>

<img src="https://latex.codecogs.com/png.latex?X^{T}" title="X^{T}" />：表示X向量转置，行向量。

<center><img src="https://latex.codecogs.com/png.latex?\begin{bmatrix}&space;x_{1}&space;&&space;x_{2}&space;&&space;\cdots&space;&&space;x_{n}&space;\end{bmatrix}" title="\begin{bmatrix} x_{1} & x_{2} & \cdots & x_{n} \end{bmatrix}" /></center>

<img src="https://latex.codecogs.com/png.latex?A_{ij}" title="A_{ij}" />：表示一个第i行第j列的元素。

<center><img src="https://latex.codecogs.com/png.latex?\begin{bmatrix}&space;a_{11}&space;&&space;a_{12}&space;&&space;\cdots&space;&&space;a_{1n}\\&space;a_{21}&space;&&space;a_{22}&space;&&space;\cdots&space;&&space;a_{2n}\\&space;\vdots&space;&&space;\vdots&space;&&space;\ddots&space;&&space;\vdots&space;\\&space;a_{41}&space;&&space;a_{42}&space;&&space;\cdots&space;&&space;a_{4n}&space;\end{bmatrix}" title="\begin{bmatrix} a_{11} & a_{12} & \cdots & a_{1n}\\ a_{21} & a_{22} & \cdots & a_{2n}\\ \vdots & \vdots & \ddots & \vdots \\ a_{41} & a_{42} & \cdots & a_{4n} \end{bmatrix}" /></center>

<img src="https://latex.codecogs.com/png.latex?A_{i}" title="A_{i}" />：第i行的元素

<img src="https://latex.codecogs.com/png.latex?A_{j}" title="A_{j}" />：第j列的元素

## 2. 矩阵乘法

矩阵<img src="https://latex.codecogs.com/png.latex?A&space;\epsilon&space;R_{m*n}" title="A \epsilon R_{m*n}" />和<img src="https://latex.codecogs.com/png.latex?B&space;\epsilon&space;R_{n*p}" title="A \epsilon R_{m*n}" />的乘积为：

<center><img src="https://latex.codecogs.com/png.latex?C&space;=&space;AB&space;\epsilon&space;R_{m*p}" title="C = AB \epsilon R_{m*p}" /></center>

其中：

<center><img src="https://latex.codecogs.com/png.latex?C_{ij}&space;=&space;\sum_{k=1}^{n}A_{ik}B_{kj}" title="C_{ij} = \sum_{k=1}^{n}A_{ik}B_{kj}" /></center>

注意：**矩阵A的列数**应该与**矩阵B的行数**相等，这样才存在矩阵的乘积

## 3. 矩阵性质

### 3.1 单位矩阵和对角矩阵

### 3.2 转置

### 3.3 对称矩阵

### 3.4 矩阵的迹

### 3.5 范数

### 3.6 线性无关和秩

### 3.7 逆

### 3.8 正交矩阵

### 3.9 矩阵的值域和零空间

### 3.10 行列式

### 3.11 二次型和半正定矩阵

### 3.12 特征值和特征向量

### 3.13 对称矩阵的特征值和特征向量


