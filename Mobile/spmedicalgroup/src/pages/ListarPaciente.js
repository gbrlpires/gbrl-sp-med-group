import React, { Component } from 'react';
import { StyleSheet, View, Text } from 'react-native';


export default class ListarPaciente extends Component {
    render(){
        return (
            <View>
                <Text>Listar Paciente</Text>
                <Text>configurando o navigation</Text>
            </View>
        );
    }

    static navigationOptions = {
        title: 'Listar Paciente',
    }
}