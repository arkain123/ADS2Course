import networkx as nx

def build_graph_from_adjacency_matrix_with_weights(adjacency_matrix):
    G = nx.Graph()
    num_nodes = len(adjacency_matrix)
    for i in range(num_nodes):
        for j in range(num_nodes):
            if i != j and adjacency_matrix[i][j] != 0:
                G.add_edge(i, j, weight=adjacency_matrix[i][j])
    return G

def build_graph_from_edges_with_weights(edges_with_weights):
    G = nx.Graph()
    for edge in edges_with_weights:
        G.add_edge(edge[0], edge[1], weight=edge[2])
    return G

def build_directed_graph(incidence_matrix):
    G = nx.DiGraph()
    num_vertices, num_edges = len(incidence_matrix), len(incidence_matrix[0])

    for edge in range(num_edges):
        start_vertex, end_vertex = -1, -1
        for vertex in range(num_vertices):
            if incidence_matrix[vertex][edge] == 1:
                if start_vertex == -1:
                    start_vertex = vertex
                else:
                    end_vertex = vertex
        G.add_edge(start_vertex, end_vertex)

    return G