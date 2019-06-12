import React, { Component } from 'react';
import { StyleSheet, View, Text, Image, TouchableOpacity, TextInput } from 'react-native';



export default class CadastrarPaciente extends Component {
    render() {
        return (
            <View
                style = { styles.container }>
                <View
                style = { styles.formContainer }>
                    <TextInput
                        placeholder="Nome do paciente"
                        style = { styles.textInputForm }
                    />

                    <TextInput
                        placeholder="Endereço do paciente"
                        style = { styles.textInputForm }
                    />

                    <TextInput
                        placeholder="RG do paciente"
                        style = { styles.textInputForm }
                    />

                    <TextInput
                        placeholder="CPF do paciente"
                        style = { styles.textInputForm }
                    />

                    <TextInput
                        placeholder="Data de nascimento"
                        style = { styles.textInputForm }
                    />

                    <TextInput
                        placeholder="Telefone do paciente"
                        style = { styles.textInputForm }
                    />  
                    <TouchableOpacity 
                        style = { styles.btnForm}
                        onPress={ () => navigation.navigate('Listar Paciente') }>

                        <Text
                        style = { styles.btnFormText}>
                            Enviar
                        </Text>
                    </TouchableOpacity>
                </View>

            </View>
    );
}

    static navigationOptions = {
        title: 'Cadastrar Paciente',
    }    
}

    const styles = StyleSheet.create({
        container: {
            flex: 1,

        },

        formContainer: {
            alignItems: 'center',
            paddingTop: 50,
        },

        textInputForm: { 
            borderBottomWidth: 1,
            borderBottomColor: '#CCCCCC',
            width: 300,
            fontSize: 16,
            paddingTop: 20,
            color: '#1B8DED'
        },

        btnForm: {
            width: 128,
            height: 46,
            textAlign: 'center',
            textTransform: 'uppercase',
            backgroundColor: '#1B8DED',
            paddingTop: 10,
            paddingLeft: 35,
            marginTop: 30
        },

        btnFormText: {
            color: 'white',
            fontSize: 20,
        }

    });