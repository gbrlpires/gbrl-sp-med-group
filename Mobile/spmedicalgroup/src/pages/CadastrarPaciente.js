import React, { Component } from 'react';
import { StyleSheet, View, Text, Image, Button, TextInput } from 'react-native';



export default class CadastrarPaciente extends Component {
    render(){
        return (
            <View>
                <Text>Cadastrar Paciente
                </Text>
                <View>
                    <Text>Nome</Text>
                    <TextInput
                        placeholder="Nome do paciente"
                    />

                    <Text>Endereço</Text>
                    <TextInput
                        placeholder="Endereço do paciente"
                    />

                    <Text>RG</Text>
                    <TextInput
                        placeholder="CPF do paciente"
                    />

                    <Text>CPF</Text>
                    <TextInput
                        placeholder="CPF do paciente"
                    />

                    <Text>Data de Nascimento</Text>
                    <TextInput
                        placeholder="Data nascimento"
                    />

                    <Text>Telefone</Text>
                    <TextInput
                        placeholder="Telefone do paciente"
                    />  
                </View>
                <Button 
                    title= "Ir para Listar"
                    onPress={ () => navigation.navigate('Listar Paciente') } 
                />
            </View>
        );
    }


    static navigationOptions = {
        title: 'Cadastrar Paciente',
    }

   
}