import numpy as np
import cv2
from matplotlib import pyplot as plt

# Second argument is a flag which specifies the way image should be read.
# cv2.IMREAD_COLOR, cv2.IMREAD_GRAYSCALE, cv2.IMREAD_UNCHANGED
# 0表示默认，默认是cv2.IMREAD_GRAYSCALE
img = cv2.imread(r'Image/test.png', 0)
# First argument is a window name which is a string.
cv2.imshow('image', img)
# The function waits for specified milliseconds for any keyboard event.
cv2.waitKey(0)
# Destroys all the windows we created.
cv2.destroyAllWindows()
# Create a empty window.
cv2.namedWindow('image', cv2.WINDOW_NORMAL)
cv2.waitKey(1000)
cv2.imshow('image', img)
cv2.waitKey(0)
cv2.destroyAllWindows()
# Save an image.
cv2.imwrite(r'Image/testgray.png', img)

cv2.imshow('image',img)
k = cv2.waitKey(0)
if k == 27:         # wait for ESC key to exit
    cv2.destroyAllWindows()
elif k == ord('s'): # wait for 's' key to save and exit
    cv2.imwrite(r'Image/testgray.png',img)
    cv2.destroyAllWindows()

# Using Matplotlib.
plt.imshow(img, cmap = 'gray', interpolation = 'bicubic')
plt.xticks([]), plt.yticks([])  # to hide tick values on X and Y axis
plt.show()

