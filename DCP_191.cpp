#include <bits/stdc++.h>
#define FI freopen ("inp.txt", "r", stdin)
#define FO freopen ("out.txt", "w", stdout)
using namespace std;

long long F(long long n) {
    return (round(pow(10, n)) - 1);
}

int main() { std::ios::sync_with_stdio(false);
    int t;
    cin >> t;
    long long n, k, ndigit, lessn;

    while(t--) {
        cin >> n >> k;
        ndigit = F(n) / k;
        lessn = F(n-1) / k;

        cout << (ndigit - lessn) << "\n";
    }

    return 0;
}
