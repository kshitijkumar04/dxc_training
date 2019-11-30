with open("aa.jpg","rb+") as fo:
    with open("copy.jpg","wb+") as focopy:
        for i in fo:
            focopy.write(i)