public class WordDictionary {
    private TrieNode _root;
    
    public WordDictionary() {
        _root = new TrieNode();    
    }
    
    public void AddWord(string word) {
        TrieNode cur = _root;
        if (!string.IsNullOrEmpty(word)) {
            foreach (char c in word) {
                int i = c - 'a';
                if (cur.children[i] == null) {
                    cur.children[i] = new TrieNode();    
                }
                cur = cur.children[i];
            }
            cur.IsEndOfWord = true; 
        }
    }
    
    public bool Search(string word) {
        return SearchRecursively(word, 0, _root);
    }

    private bool SearchRecursively(string word, int i, TrieNode node) {
        if (i == word.Length) {
            return node.IsEndOfWord;
        }

        char c = word[i];

        if (c == '.') {
            foreach (TrieNode child in node.children) {
                if (child != null && SearchRecursively(word, i + 1, child)) {
                    return true;
                }
            }
            return false;
        }
        else {
            int charIndex = c - 'a';
            if (node.children[charIndex] == null) {
                return false;
            }
            return SearchRecursively(word, i + 1, node.children[charIndex]);
        }
    }
}

public class TrieNode {
    public TrieNode[] children;
    public bool IsEndOfWord { get; set; }

    public TrieNode() {
        children = new TrieNode[26];
        IsEndOfWord = false;
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */