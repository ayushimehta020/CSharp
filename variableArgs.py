def op(c, *args):
    if c == 1:
        ans = 0
        for i in args[0]:
            ans = ans + i
    elif c == 2:
        ans = args[0][0]
        for i in range(1, len(args[0])):
            ans = ans - args[0][i]
    elif c == 3:
        ans = 1
        for i in args[0]:
            ans = ans * i
    elif c == 4:
        ans = args[0][0]
        for i in range(1, len(args[0])):
            ans = ans / args[0][i]
    return ans

n = int(input("Enter Number of Values : "))
lst = []
for i in range(1, n + 1):
    lst.append(int(input("Enter Number : ")))
print ("1 - Addition\n2 - Subtraction\n3 - Multiplication\n4 - Division")
choice = int(input("Enter Your Choice : "))
print(op(choice, lst))