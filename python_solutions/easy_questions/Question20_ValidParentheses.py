def isValid(self, s):
        """
        :type s: str
        :rtype: bool
        """
        lst = []
        for ch in s:
            if ch == '}' or ch == ']' or ch == ')':
                if lst == []:
                    return False
                if (lst[-1] == '[' and ch == ']') or (lst[-1] == '{' and ch == '}') or (lst[-1] == '(' and ch == ')'):
                    lst.pop(-1)
                else:
                    return False
            else:
                lst.append(ch)

        return lst == []