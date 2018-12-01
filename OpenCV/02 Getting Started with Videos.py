import cv2

# argument can be either the device index or the name of a video file.
cap = cv2.VideoCapture(0)

# Using cap.get(propId) method where propId is a number from 0 to 18 to access the features of video,
# and the cap.set(propId, value) to modify it.
print('The frame size is %(w)s * %(h)s' %
      {'w': cap.get(3), 'h': cap.get(4)})
print('You can press \'q\' to close.')
# retsetw = cap.set(3, 320)
# retseth = cap.set(4, 240)

while(True):
    # Capture frame-by-frame, ret is a bool value
    ret, frame = cap.read()

    # Our operations on the frame come here
    gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)

    # Display the resulting frame
    cv2.imshow('frame',gray)
    if cv2.waitKey(1) & 0xFF == ord('q'):
        break

# When everything done, release the capture
cap.release()
cv2.destroyAllWindows()

cap = cv2.VideoCapture(0)

# Define the codec and create VideoWriter object
fourcc = cv2.VideoWriter_fourcc(*'XVID')
out = cv2.VideoWriter(r'Video/output.avi',fourcc, 20.0, (640,480))

while(cap.isOpened()):
    ret, frame = cap.read()
    if ret==True:
        # 旋转180°
        # frame = cv2.flip(frame,0)

        # write the flipped frame
        out.write(frame)

        cv2.imshow('frame',frame)
        if cv2.waitKey(1) & 0xFF == ord('q'):
            break
    else:
        break

# Release everything if job is finished
cap.release()
out.release()
cv2.destroyAllWindows()
