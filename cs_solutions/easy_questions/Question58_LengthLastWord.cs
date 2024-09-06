public int LengthOfLastWord(string s) {
        int length = 0;
        string lastWord = "";
        bool flag = true;
        for(int i= s.Length-1; i>=0 ; i--){
            if(s[i] !=' ')
               length++;
            if(s[i] == ' ' && length>0)
                return length;     
        }
        return length;
    }