public static int leftrightString(string S)
    {
        int left=0, right=S.Length-1; 
        char[] c= S.ToCharArray();
        for (int i = 1; i < S.Length; i++){
            if (c[0]==c[1])
            {
                left=2;
                if (c[0]==c[i]){
                    left = i-left;
                }
            }
            if(c[S.Length-1]==c[i]){
                right =i-right;
            }
        }
        return left<right?left:right;
    }