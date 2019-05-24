import React, { Component } from 'react';

import '../List.css';

class ListarPaciente extends Component {
    constructor() {
        super();
        this.state = {
            lista: [],
            pacienteNome: "",
            dataNascimento: "",
            endereco: "",
            cep: "",
            cpf: "",
            rg: "",
            telefone: ""
        }

        this.atualizaEstadoNome = this.atualizaEstadoNome.bind(this);
        this.atualizaEstadoNascimento = this.atualizaEstadoNascimento.bind(this);
        this.atualizaEstadoEndereco = this.atualizaEstadoEndereco.bind(this);
        this.atualizaEstadoCep = this.atualizaEstadoCep.bind(this);
        this.atualizaEstadoCpf = this.atualizaEstadoCpf.bind(this);
        this.atualizaEstadoRg = this.atualizaEstadoRg.bind(this);
        this.atualizaEstadoTelefone = this.atualizaEstadoTelefone.bind(this);

    }
    
    ListaPaciente(){
        fetch('http://192.168.3.86:5000/api/Pacientes')
          .then(resposta => resposta.json())
          .then(data => this.setState({lista : data}))
          .catch((erro) => console.log(erro))
    }
  
    componentDidMount() {
        this.ListaPaciente();
    }

    atualizaEstadoLista(event) {
        this.setState({lista: event.target.value});
    }

    atualizaEstadoNome(event) {
        this.setState({pacienteNome: event.target.value});
    }

    atualizaEstadoNascimento(event) {
        this.setState({dataNascimento: event.target.value});
    }

    atualizaEstadoEndereco(event) {
        this.setState({endereco: event.target.value});
    }

    atualizaEstadoCep(event) {
        this.setState({cep: event.target.value});
    }

    atualizaEstadoCpf(event) {
        this.setState({cpf: event.target.value});
    }

    atualizaEstadoRg(event) {
        this.setState({rg: event.target.value});
    }

    atualizaEstadoTelefone(event) {
        this.setState({telefone: event.target.value});
    }

    render() {
        return (
            <section className="">
                <h2>Pacientes</h2>
                <table className="table-list">
                    <thead className="table-list__head">
                        <tr>
                            <th>Nome do Paciente</th>
                            <th>Data de Nascimento</th>
                            <th>Endereço</th>
                            <th>CEP</th>
                            <th>CPF</th>
                            <th>RG</th>
                            <th>Telefone</th>
                        </tr>
                    </thead>
                    <tbody className="table-list__body">
                        {
                            this.state.lista.map(function(listaPaciente){
                                return(
                                    <tr key={listaPaciente.id}>
                                        <td>{listaPaciente.pacienteNome}</td>
                                        <td>{listaPaciente.dataNascimento}</td>
                                        <td>{listaPaciente.endereco}</td>
                                        <td>{listaPaciente.cep}</td>
                                        <td>{listaPaciente.cpf}</td>
                                        <td>{listaPaciente.rg}</td>
                                        <td>{listaPaciente.telefone}</td>
                                    </tr>
                                );
                            })
                        }
                    </tbody>
                </table>
            </section>
        );
    }


} 

export default ListarPaciente;