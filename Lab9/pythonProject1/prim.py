import heapq

def prim(edges):
    graph = {}
    for edge in edges:
        node1, node2, weight = edge
        if node1 not in graph:
            graph[node1] = []
        graph[node1].append((node2, weight))
        if node2 not in graph:
            graph[node2] = []
        graph[node2].append((node1, weight))

    start_node = list(graph.keys())[0]
    visited = {start_node}
    min_spanning_tree = []
    min_heap = [(0, start_node, None)]

    while min_heap:
        weight, current_node, prev_node = heapq.heappop(min_heap)

        if current_node not in visited:
            visited.add(current_node)
            if prev_node is not None:
                min_spanning_tree.append((prev_node, current_node, weight))

            for neighbor, edge_weight in graph[current_node]:
                if neighbor not in visited:
                    heapq.heappush(min_heap, (edge_weight, neighbor, current_node))

    return min_spanning_tree