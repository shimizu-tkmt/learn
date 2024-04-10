import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";
import { Products } from "./components/Products";
import { CreateProduct } from "./components/CreateProduct";

const AppRoutes = [
    {
    index: true,
    element: <Home />
    },
    {
    path: '/counter',
    element: <Counter />
    },
    {
    path: '/fetch-data',
    element: <FetchData />
    },
    {
    path: '/products',
    element: <Products />
    },
    {
        path: '/create',
        element: <CreateProduct />
    }
];

export default AppRoutes;
