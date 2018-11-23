def cocktail_shaker(collection):
    length = len(collection)
    right = length - 1
    left = 0
    while right > left:
        for i in range(left, right, 1):
            if collection[i] > collection[i+1]:
                collection[i], collection[i+1] = collection[i+1] , collection[i]
            left = left + 1
        for j in range(right, left, -1):
            if collection[j] < collection[j+1]:
                collection[j], collection[j+1] = collection[j+1] , collection[j]
            right = right - 1
    return collection

print(cocktail_shaker([1, 4, 2, 7]))
