import React, { Component } from 'react';

import '../Form.css';
import './CadastrarPaciente.css';

class CadastrarPaciente extends Component {
    render() {
      return (
        <div>
            <h2 className="form__title">Cadastrar Paciente</h2>
            <form onSubmit={this.CadastraPaciente.bind(this)} className="form form--paciente" noValidate>
                <input 
                    type="text"
                    id="paciente__nome"
                    value={this.state.nome}
                    onChange={this.atualizaEstadoNome.bind(this)}
                    placeholder="Preencha o nome do paciente" required
                />

                <input 
                    type="text"
                    id="paciente__endereco"
                    value={this.state.endereco}
                    onChange={this.atualizaEstadoEndereco.bind(this)}
                    placeholder="Preencha o endereço do paciente" required
                />

                <input 
                    type="text"
                    id="paciente__cpf"
                    value={this.state.cpf}
                    onChange={this.atualizaEstadoCpf.bind(this)}
                    placeholder="Preencha o CPF do paciente" required
                />

                <input 
                    type="text"
                    id="paciente__rg"
                    value={this.state.rg}
                    onChange={this.atualizaEstadoRg.bind(this)}
                    placeholder="Preencha o RG do paciente" required
                />

                <input 
                    type="text"
                    id="paciente__tel"
                    value={this.state.tel}
                    onChange={this.atualizaEstadoTel.bind(this)}
                    placeholder="Preencha o telefone do paciente" required
                />
            </form>
            
        </div>
      );
    }
  }
  
  export default CadastrarPaciente;




