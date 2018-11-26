squares = [1, 4, 9, 16, 25]
print(squares)

# list can be indexed and sliced
print(squares[0])
print(squares[-1])
print(squares[-3:])
# The following slice returns a new copy of list
print(squares[:])
# Lists also support operations like concatenation(ÁªºÏ):
print(squares + [36, 49, 64, 100])
# Unlike strings, which are immutable, lists are a mutable type. It is possible to change their content:
squares[0] = 100
print(squares)
# You can also add new items at the end of list, by using the methond, append().
squares.append(100)
print(squares)
# Assignment to slices is also possible, and this can even change the size of the list or clear it entirely.
letters = ['a', 'b', 'c', 'd', 'e', 'f', 'g']
print(letters)
letters[2:5] = ['C', 'D', 'E']
print(letters)
letters[2:5] = []
print(letters)
letters[:] = []
print(letters)
# The built-in function len() also applies to lists:
print('The length of list is {0}'.format(len(letters)))
# It is possible to nest lists (create lists containing other lists), for example:
a = ['a', 'b', 'c']
b = [1, 2, 3]
x = [a, b]
print('List a is {0}'.format(a))
print('List b is {0}'.format(b))
print(x)
