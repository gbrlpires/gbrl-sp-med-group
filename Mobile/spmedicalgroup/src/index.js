import CadastrarPaciente from "./pages/CadastrarPaciente";
import ListarPaciente from "./pages/ListarPaciente";

import { createAppContainer, createDrawerNavigator, createStackNavigator } from "react-navigation";

const Routes = createAppContainer(
    createStackNavigator({
        CadastrarPaciente,
        ListarPaciente
    }),
    
);

export default Routes;