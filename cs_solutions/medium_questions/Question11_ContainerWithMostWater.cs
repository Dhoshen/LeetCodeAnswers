public int MaxArea(int[] height) {  
        int right = height.Length-1;
        int left = 0;
        int max_amount = 0;
        while(left<right)
        {
            if((right-left)*Math.Min(height[right],height[left])>max_amount)
                max_amount = (right-left)*Math.Min(height[right],height[left]);
            if(height[right]>height[left])
                left++;
            else
                right--;
        }
        return max_amount;
    }