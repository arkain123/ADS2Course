import main
import values as v
import dijkstra as dj
import networkx as nx
import matplotlib.pyplot as plt
import prim as pr
import numpy as np

choose = int(input("Choose lab (1/2/3): "))
if choose == 1:
    task = int(input("Choose task (1/2/3): "))
    if task == 1:
        G_edges_with_weights = main.build_graph_from_edges_with_weights(v.edges_with_weights)

        # Отрисовка графа по ребрам
        pos = nx.spring_layout(G_edges_with_weights)  # позиционирование вершин
        nx.draw(G_edges_with_weights, pos, with_labels=True, font_weight='bold', node_size=1000, node_color='lightblue',
                edge_color='gray', font_color='black', )
        # Добавление подписей с длинами каждого ребра
        labels = nx.get_edge_attributes(G_edges_with_weights, 'weight')
        nx.draw_networkx_edge_labels(G_edges_with_weights, pos, edge_labels=labels)

        plt.show()

    if task == 2:
        G_adjacency_matrix_with_weights = main.build_graph_from_adjacency_matrix_with_weights(
            v.adjacency_matrix_with_weights)

        # Отрисовка графа по матрице
        plt.figure(figsize=(6, 6))
        pos_adjacency_with_weights = nx.spring_layout(G_adjacency_matrix_with_weights)
        edge_labels = nx.get_edge_attributes(G_adjacency_matrix_with_weights, 'weight')
        nx.draw_networkx_edge_labels(G_adjacency_matrix_with_weights, pos_adjacency_with_weights,
                                     edge_labels=edge_labels)
        nx.draw(G_adjacency_matrix_with_weights, pos_adjacency_with_weights, with_labels=True, font_weight='bold',
                node_size=1000, node_color='skyblue', edge_color='gray', font_color='black')

        plt.show()

    if task == 3:
        G_adjacency_matrix_with_weights = main.build_graph_from_adjacency_matrix_with_weights(
            v.adjacency_matrix_with_weights)

        plt.figure(figsize=(6, 6))
        pos_adjacency_with_weights = nx.spring_layout(G_adjacency_matrix_with_weights)
        edge_labels = nx.get_edge_attributes(G_adjacency_matrix_with_weights, 'weight')
        nx.draw_networkx_edge_labels(G_adjacency_matrix_with_weights, pos_adjacency_with_weights,
                                     edge_labels=edge_labels)
        nx.draw(G_adjacency_matrix_with_weights, pos_adjacency_with_weights, with_labels=True, font_weight='bold',
                node_size=1000, node_color='skyblue', edge_color='gray', font_color='black')

        plt.show()

if choose == 2:
    G_edges_with_weights = main.build_graph_from_edges_with_weights(v.edges_with_weights)

    distances = dj.dijkstra(v.edges_with_weights, 0)
    print(distances)
    print("minimal path: " + str(distances[len(distances) - 1]))

    # Отрисовка графа по ребрам
    pos = nx.spring_layout(G_edges_with_weights)  # позиционирование вершин
    nx.draw(G_edges_with_weights, pos, with_labels=True, font_weight='bold', node_size=1000, node_color='lightblue',
            edge_color='gray', font_color='black')
    # Добавление подписей с длинами каждого ребра
    labels = nx.get_edge_attributes(G_edges_with_weights, 'weight')
    nx.draw_networkx_edge_labels(G_edges_with_weights, pos, edge_labels=labels)

    plt.show()

if choose == 3:
    task = int(input("Choose task (1/2): "))
    if task == 1:
        G_graph = main.build_graph_from_edges_with_weights(v.graph)

        # Отрисовка графа по ребрам 1
        pos = nx.spring_layout(G_graph)  # позиционирование вершин
        nx.draw(G_graph, pos, with_labels=True, font_weight='bold', node_size=1000, node_color='lightblue',
                edge_color='gray', font_color='black')
        labels = nx.get_edge_attributes(G_graph, 'weight')
        nx.draw_networkx_edge_labels(G_graph, pos, edge_labels=labels)

        plt.show()

    if task == 2:
        min_spanning_tree = pr.prim(v.graph)
        G_spanning_tree = main.build_graph_from_edges_with_weights(min_spanning_tree)
        print(min_spanning_tree)
        # Отрисовка графа по ребрам 2
        pos = nx.spring_layout(G_spanning_tree)  # позиционирование вершин
        nx.draw(G_spanning_tree, pos, with_labels=True, font_weight='bold', node_size=1000, node_color='lightblue',
                edge_color='gray', font_color='black')
        labels = nx.get_edge_attributes(G_spanning_tree, 'weight')
        nx.draw_networkx_edge_labels(G_spanning_tree, pos, edge_labels=labels)

        plt.show()
