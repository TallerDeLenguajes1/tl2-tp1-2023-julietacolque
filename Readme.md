# ¿Cuál de estas relaciones considera que se realiza por composición y cuál por agregación?

## La relacion de composición es de la clase cliente y pedido. Pues un cliente no puede existir si no hizo algun pedido. Y la de agregacion es de la clase cadeteria con cadete, un cadete puede existir de manera individual.

# ¿Qué métodos considera que debería tener la clase Cadetería y la clase Cadete?

## La clase Cadeteria deberia tener los metodos de: Asignar pedido, Reasignar pedido, Cambiar estado del pedido.
## La clase Cadete, cambiar de estado un metodo usado por la clase cadeteria, Agregar pedido a su lista de pedidos, remover el pedido.
# Teniendo en cuenta los principios de abstracción y ocultamiento, que atributos,propiedades y métodos deberían ser públicos y cuáles privados.

## Todos los atributos deberian ser privados, y con sus respectivas propiedades en caso de necesitarlos desde otro lugar, y todos los metodos publicos salvo aquellos que sean necesarios para realizar alguna tarea dentro de la propia clase y que no es necesario que sea visto por el usuario.

# ¿Cómo diseñaría los constructores de cada una de las clases?

## En el caso de cadetes, puse un constructor con los atributos y la inicializacion de la lista de pedidos.
## Cadeteria lo mismo y declare la lista de cadetes.
## Cliente los datos son obligatorios es decir que solo tengo el constructor que he creado
## En pedido tengo un constructor vacio porque cuando le remuevo un pedido al cadete en caso de no encontrar coincidencias a partir del id, entonces retorna un pedido vacio.


# ¿Se le ocurre otra forma que podría haberse realizado el diseño de clases?

#