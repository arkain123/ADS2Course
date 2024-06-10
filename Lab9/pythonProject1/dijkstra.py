# def create_graph(edges):
#     graph = {}
#     for node1, node2, weight in edges:
#         if node1 not in graph:
#             graph[node1] = {}
#         if node2 not in graph:
#             graph[node2] = {}
#         graph[node1][node2] = weight
#         graph[node2][node1] = weight
#     return graph
#
#
# def dijkstra(edges, start):
#     graph = create_graph(edges)
#     distances = {node: float('infinity') for node in graph}
#     distances[start] = 0
#
#     visited = set()
#     while len(visited) < len(graph):
#         current_node = None
#         min_distance = float('infinity')
#         for node in graph:
#             if node not in visited and distances[node] < min_distance:
#                 current_node = node
#                 min_distance = distances[node]
#
#         visited.add(current_node)
#
#         for neighbor, weight in graph[current_node].items():
#             distance = distances[current_node] + weight
#             if distance < distances[neighbor]:
#                 distances[neighbor] = distance
#
#     return distances
import heapq

def dijkstra(graph, start):
    distances = {node: float('inf') for node in set([node1 for node1, node2, weight in graph] + [node2 for node1, node2, weight in graph])}
    distances[start] = 0
    min_heap = [(0, start)]

    while min_heap:
        current_distance, current_node = heapq.heappop(min_heap)

        if current_distance > distances[current_node]:
            continue

        for node1, node2, edge_weight in graph:
            if node1 == current_node:
                distance = current_distance + edge_weight
                if distance < distances[node2]:
                    distances[node2] = distance
                    heapq.heappush(min_heap, (distance, node2))

        for node1, node2, edge_weight in graph:
            if node2 == current_node:
                distance = current_distance + edge_weight
                if distance < distances[node1]:
                    distances[node1] = distance
                    heapq.heappush(min_heap, (distance, node1))

    return distances