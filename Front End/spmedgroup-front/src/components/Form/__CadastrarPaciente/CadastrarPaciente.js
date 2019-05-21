import React, { Component } from 'react';

import '../Form.css';
import './CadastrarPaciente.css';

import axios from 'axios';

class CadastrarPaciente extends Component {
    // constructor() {
    //     super();

    //     this.state = {
    //         nome: "",
    //         endereco: "",
    //         cpf: "",
    //         rg: "",
    //         telefone: ""
    //     };
    // }

    // componentWillMount() {
    //     this.CadastraPaciente();
    // }

    // atualizaEstadoNome(event) {
    //     this.setState({nome: event.target.value});
    // }

    // atualizaEstadoEndereco(event) {
    //     this.setState({endereco: event.target.value});
    // }

    // atualizaEstadoCpf(event) {
    //     this.setState({cpf: event.target.value});
    // }

    // atualizaEstadoRg(event) {
    //     this.setState({rg: event.target.value});
    // }

    // atualizaEstadoTelefone(event) {
    //     this.setState({telefone: event.target.value});
    // }


    // CadastraPaciente(event) {
    //     event.preventDefault();

    //     let paciente = {
    //         nome: this.state.nome,
    //         endereco: this.state.endereco,
    //         cpf: this.state.cpf,
    //         rg: this.state.rg,
    //         telefone: this.state.telefone
    //     };

    //     axios.post("colocar o endereco aqui");

    //     console.log(paciente);
    // }


    render() {
      return (
        <div className="form-flexbox">
            <h2 className="form__title">Cadastrar Paciente</h2>
            <form 
            // onSubmit={this.CadastraPaciente.bind(this)} 
            className="form form--paciente" noValidate>
                <fieldset>
                    <label>Nome</label>
                    <input 
                        className="input-text"
                        type="text"
                        id="paciente__nome"
                        // value={this.state.nome}
                        // onChange={this.atualizaEstadoNome.bind(this)}
                        placeholder="Preencha o nome do paciente" required
                        />
                </fieldset>

                <fieldset>
                    <label>Endereço</label>
                    <input 
                        className="input-text"
                        type="text"
                        id="paciente__endereco"
                        // value={this.state.endereco}
                        // onChange={this.atualizaEstadoEndereco.bind(this)}
                        placeholder="Preencha o endereço do paciente" required
                        />
                </fieldset>

                <fieldset>
                    <label>CPF</label>
                    <input 
                        className="input-text"
                        type="text"
                        id="paciente__cpf"
                        // value={this.state.cpf}
                        // onChange={this.atualizaEstadoCpf.bind(this)}
                        placeholder="Preencha o CPF do paciente" required
                        />
                </fieldset>

                <fieldset>
                    <label>RG</label>
                    <input 
                        className="input-text"
                        type="text"
                        id="paciente__rg"
                        // value={this.state.rg}
                        // onChange={this.atualizaEstadoRg.bind(this)}
                        placeholder="Preencha o RG do paciente" required
                        />
                </fieldset>
                
                <fieldset>
                    <label>Telefone</label>
                    <input 
                        className="input-text"
                        type="text"
                        id="paciente__telefone"
                        // value={this.state.telefone}
                        // onChange={this.atualizaEstadoTelefone.bind(this)}
                        placeholder="Preencha o telefone do paciente" required
                        />
                </fieldset>
                <button type="submit" className="btn btn--b">Cadastrar</button>
            </form>
            
        </div>
      );
    }
  }
  
  export default CadastrarPaciente;




