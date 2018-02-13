def number_needed(a, b):
    temp ={}
    for i in a:
        if i in temp:
            temp[i]+=1
        else:
            temp[i] =1
    count =0
    for i in b:
        if i in temp:
            temp[i]-=1
        else:
            count+=1
    for key,val in temp.iteritems():
        count = count + abs(val)
    
    return count
        
            

a = raw_input().strip()
b = raw_input().strip()

print number_needed(a, b)
