#define ONLINE_JUDGE 1
#include <bits/stdc++.h>
using namespace std;

int main (void)
{

    long long tc,n,arr[101],r,p,maxi,i;

    scanf("%lld",&tc);

    while (tc--)
    {
        scanf("%lld %lld %lld",&n,&r,&p);

        if (n == 0)
        {
            if (p > r)
                maxi = 0;
            else
                maxi = r-p;

            printf("%lld\n",maxi);
        }
        else
        {
            for (i=0; i<n; i++)
            	scanf("%lld",&arr[i]);

            sort(arr,arr+i);
			maxi = max(p, arr[0]);

            for (i=1; i<n; i++)
                if ((arr[i]-arr[i-1]) > maxi)
                    maxi = (arr[i]-arr[i-1]);

			maxi = max(maxi, r-arr[n-1]);
            printf("%lld\n",maxi-p);
        }
    }

    return 0;
}