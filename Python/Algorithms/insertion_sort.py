def insertion_sort(arr):
    length = len(arr)
    for i in range(1, length - 1):
        key = arr[i]
        j = i - 1
        while j >= 0 and arr[j] > key:
            arr[j+1] = arr[j]
            j = j - 1
        arr[j+1] = key
    return arr

print(insertion_sort([1, 4, 2, 7]))
