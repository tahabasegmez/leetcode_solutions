public class Trie {
    private TrieNodeDict _root;

    public Trie() {
        _root = new TrieNodeDict();
    }
    
    public void Insert(string word) {

        TrieNodeDict cur;
        cur = _root;

        foreach (char c in word) {
            if (!cur.children.ContainsKey(c)) {
                cur.children.Add(c, new TrieNodeDict());
            }

            cur = cur.children[c];
        }

        cur.IsEndOfWord = true;
    }
    
    public bool Search(string word) {

        TrieNodeDict cur;
        cur = _root;

        foreach (char c in word) {

            if (!cur.children.ContainsKey(c)) {
                return false;
            }
            else {
                cur = cur.children[c];
            }
        }

        if (cur.IsEndOfWord) return true; else return false;
    }
    
    public bool StartsWith(string prefix) {
        TrieNodeDict cur;
        cur = _root;

        foreach (char c in prefix) {

            if (!cur.children.ContainsKey(c)) {
                return false;
            }
            else {
                cur = cur.children[c];
            }
        }

        return true;
    }
}

public class TrieNodeDict {
    public Dictionary<char, TrieNodeDict> children {get; set;}
    public bool IsEndOfWord {get; set;}
    
    public TrieNodeDict () {
        children = new Dictionary<char, TrieNodeDict>();
        IsEndOfWord = false;
    }
}