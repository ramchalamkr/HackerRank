def gcd(a,b):
    if(b==0):
        return a
    else:
        return gcd(b,a%b)

def array_left_rotation(a, n, k):
    for i in range(gcd(k,n)):
        temp = a[i]
        j=i;
        while True:
            t = j+k
            if(t>=n):
                t = t-n;
            if t==i:
                break
            a[j] = a[t]
            j = t
        a[j] = temp
    return a
            
  

n, k = map(int, raw_input().strip().split(' '))
a = map(int, raw_input().strip().split(' '))
answer = array_left_rotation(a, n, k);
print ' '.join(map(str,answer))
