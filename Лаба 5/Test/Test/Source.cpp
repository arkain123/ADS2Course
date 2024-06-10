#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

struct Node {
    vector<int> keys;
    vector<Node*> children;

    Node() {
        keys = vector<int>();
        children = vector<Node*>();
    }
};

class TwoThreeFourTree {
private:
    Node* root;

public:
    TwoThreeFourTree() {
        root = new Node();
    }

    void insert(int key) {
        if (root->keys.size() == 3) {
            Node* new_root = new Node();
            new_root->children.push_back(root);
            split_child(new_root, 0);
            root = new_root;
        }
        insert_non_full(root, key);
    }

    void insert_non_full(Node* node, int key) {
        if (node->children.empty()) {
            node->keys.push_back(key);
            sort(node->keys.begin(), node->keys.end());
        }
        else {
            int i = node->keys.size() - 1;
            while (i >= 0 && key < node->keys[i]) {
                i--;
            }
            i++;
            if (node->children[i]->keys.size() == 3) {
                split_child(node, i);
                if (key > node->keys[i]) {
                    i++;
                }
            }
            insert_non_full(node->children[i], key);
        }
    }

    void split_child(Node* parent, int i) {
        Node* node = parent->children[i];
        Node* new_node = new Node();
        new_node->keys.push_back(node->keys[2]);
        node->keys.erase(node->keys.begin() + 2);
        if (!node->children.empty()) {
            new_node->children.push_back(node->children[2]);
            new_node->children.push_back(node->children[3]);
            node->children.erase(node->children.begin() + 2, node->children.begin() + 4);
        }
        parent->keys.insert(parent->keys.begin() + i, node->keys[1]);
        node->keys.erase(node->keys.begin() + 1);
        parent->children.insert(parent->children.begin() + i + 1, new_node);
    }

    void print_tree(Node* node, string indent = "", string position = "R----") {
        cout << indent << position;
        for (int i = 0; i < node->keys.size(); i++) {
            cout << node->keys[i] << " ";
        }
        cout << endl;
        if (!node->children.empty()) {
            for (int i = 0; i < node->children.size(); i++) {
                if (i == 0) {
                    print_tree(node->children[i], indent + "     ", "L----");
                }
                else {
                    print_tree(node->children[i], indent + "     ", "R----");
                }
            }
        }
    }

    void print_tree() {
        print_tree(root);
    }
};

int main() {
    TwoThreeFourTree tree;
    int keys[] = { 4, 6, 2, 8, 11, 15, 12, 21,17, 13, 35, 37, 45, 87, 92, 29, 77, 76, 75, 79 };
    for (int i = 0; i < sizeof(keys) / sizeof(keys[0]); i++) {
        tree.insert(keys[i]);
        tree.print_tree();
        cout << "\n";
    }
    return 0;
}