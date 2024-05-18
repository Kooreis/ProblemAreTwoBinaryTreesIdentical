def identicalTrees(a, b):
    if a is None and b is None:
        return True
    if a is not None and b is not None:
        return ((a.data == b.data) and
                identicalTrees(a.left, b.left) and
                identicalTrees(a.right, b.right))
    return False