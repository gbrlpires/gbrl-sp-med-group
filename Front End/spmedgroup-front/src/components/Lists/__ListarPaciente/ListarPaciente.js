import React from 'react';

import '../List.css';

import Axios from 'axios';

class ListarPaciente extends Component {
    constructor() {
        super();
        this.state = {
            lista: [],
            nome: "",
            nascimento: "",
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


    atualizaEstadoNome(event) {
        this.setState({nome: event.target.value});
    }

    atualizaEstadoNascimento(event) {
        this.setState({nascimento: event.target.value});
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

    ListaPaciente(event) {
        event.preventDefault();

        let listaPaciente = {
            lista: this.state.lista,
            pacienteNome: this.state.nome,
            dataNascimento: this.state.nascimento,
            endereco: this.state.endereco,
            cep: this.state.cep,
            cpf: this.state.cpf,
            rg: this.state.rg,
            telefone: this.state.telefone
        };

        axios.get("http://192.168.3.86:5000/api/Pacientes", listaPaciente);

        console.log(listaPaciente); 
    }

    componentDidMount(){
        this.ListaPaciente();
    }


    render() {
        return (
            <section className="">
                <h2>Pacientes</h2>
                <table className="table-list">
                    <thead>
                        <tr>
                            <th>{this.state.nome}</th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            this.state.lista.map(function(listaPaciente){
                                return(
                                    <tr key={listaPaciente.id}>
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