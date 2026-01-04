public class LongestPalindromeSubstring {
    public string LongestPalindrome(string s) {
        
        if (string.IsNullOrEmpty(s))
            return "";

        
        int[] longestPalindromeIndices = { 0, 0 };

        
        for (int i = 0; i < s.Length; ++i) {
           
            int[] currentIndices = ExpandAroundCenter(s, i, i);

            
            if (currentIndices[1] - currentIndices[0] > longestPalindromeIndices[1] - longestPalindromeIndices[0]) {
               
                longestPalindromeIndices = currentIndices;
            }

           
            if (i + 1 < s.Length && s[i] == s[i + 1]) {
               
                int[] evenIndices = ExpandAroundCenter(s, i, i + 1);

               
                if (evenIndices[1] - evenIndices[0] > longestPalindromeIndices[1] - longestPalindromeIndices[0]) {
                 
                    longestPalindromeIndices = evenIndices;
                }
            }
        }

        
        return s.Substring(longestPalindromeIndices[0], longestPalindromeIndices[1] - longestPalindromeIndices[0] + 1);
    }

    
    private int[] ExpandAroundCenter(string s, int i, int j) {
       
        while (i >= 0 && j < s.Length && s[i] == s[j]) {
            i--; 
            j++; 
        }
      
        return new int[] { i + 1, j - 1 };
    }
}