public int StrStr(string haystack, string needle) {
        bool check = false;
        for(int i=0; i < haystack.Length;i++){
            if(haystack[i] == needle[0]){
                check = true;
                if(needle.Length == 1)
                    return i;
            }       
        }
        if(!check){
            return -1;
        }
        int place = 1;
        bool flag = true;
        for(int i=0; i <haystack.Length-1;i++){
            if(haystack[i] == needle[0]){
                for(int j =i+1; j<haystack.Length && flag && place<needle.Length; j++){
                    if(haystack[j] == needle[place])
                        place++;
                    else{
                        flag = false;
                        place = 1;
                    }    
                }
                if(flag){
                    if(i+needle.Length<=haystack.Length)
                        return i;       
                }
                flag = true;         
            }
        }
        if(!flag)
            return -1;
        return -1;
    }