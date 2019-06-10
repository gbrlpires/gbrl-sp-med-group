// import {AppRegistry} from 'react-native';
// import App from './App';
// import {name as appName} from './app.json';

// AppRegistry.registerComponent(appName, () => App);


import { createBottomTabNavigator, createAppContainer, createDrawerNavigator } from "react-navigation";

import CadastrarPaciente from "./pages/CadastrarPaciente";
import ListarPaciente from "./pages/ListarPaciente";

const MainNavigator = createDrawerNavigator(
    {
        CadastrarPaciente,
        ListarPaciente
    },
    
)