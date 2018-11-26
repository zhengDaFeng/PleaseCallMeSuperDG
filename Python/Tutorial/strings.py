# single quotes
print('wrapped by single quotes')
# double quotes
print("wrapped bu double quotes")
# triple quoted
print("""
+---+---+---+---+---+---+
 | P | y | t | h | o | n |
 +---+---+---+---+---+---+
 0   1   2   3   4   5   6
-6  -5  -4  -3  -2  -1
""")

print('She doesn\'t like me!') # use \' to escape the single quote
print("I'm fond of her") # use double quotes so you can show the single
print('"Yes," they said.')
print("\"Yes,\" they said.")
s = 'First line. \nSecond line.'
print(s)
path1 = 'C:\some\name'
path2 = r'C:\some\name'
print(path1)
print(path2)
print(3 * 'un' + 'ium')
print('Put several strings within parentheses '
      'to have them joined together.')
word = 'Python'
print(word[0])
print(word[-6])
print(word[0:2])
print(word[:2] + word[2:])
print(word[-2:])

# Python strings cannot be changed - they are immutable
# word[0] = 'J'
# If you need a different string, you should create a new one.
print('J' + word[1:])
# The build-in function len() returns the length of string:
print(len(word))
# printf - string format - str.format()
print("%(lang)s has %(num)03d quote types." %{"lang": "Python", 'num': 3})
print("The sum of 1 + 2 is {0}".format(1+2))
