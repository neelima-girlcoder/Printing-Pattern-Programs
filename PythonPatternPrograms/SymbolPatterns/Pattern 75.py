n=5
for x in range(1, n+1):
    for y in range(1, x+1):
        for y in range(1, y + 1):
            print("*", end="")
        print()
    print()