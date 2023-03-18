USE Pizzaria;

INSERT INTO Bordas
    (nome)
VALUES
    ('catupiry')

INSERT INTO Bordas
    (nome)
VALUES
    ('cheddar'),
    ('chocolate preto'),
    ('chocolate branco')

INSERT INTO pizza
    (id_massas, id_bordas)
VALUES
    (2, 1)

INSERT INTO pizza
    (id_massas, id_bordas)
VALUES
    (3, 3)

INSERT INTO
    (id_pizzas, id_sabores)
VALUES
    (1, 2),
    (2, 3)

INSERT INTO pedidos
    (id_pizzas, id_status)
VALUES
    (1, 3),
    (2, 1)