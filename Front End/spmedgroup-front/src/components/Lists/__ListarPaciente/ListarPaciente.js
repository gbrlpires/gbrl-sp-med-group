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
            <section>
                <div className="list wrapper">
                    <h2 className="list__title">Pacientes</h2>
                    <div>
                        {
                            this.state.lista.map(function(listaPaciente)
                            {
                                return(
                                    <ul key={listaPaciente.id} className="list__content">
                                        <li className="list__item">
                                            <h4 className="list__item--title">Nome do Paciente</h4>
                                            <p className="list__item--info">{listaPaciente.pacienteNome}</p>
                                        </li>
                                        <li className="list__item">
                                            <h4 className="list__item--title">Data de nascimento</h4>
                                            <p className="list__item--info">{listaPaciente.dataNascimento}</p>
                                        </li>
                                        <li className="list__item">
                                            <h4 className="list__item--title">Endereço</h4>
                                            <p className="list__item--info">{listaPaciente.endereco}</p>
                                        </li>
                                        <li className="list__item">
                                            <h4 className="list__item--title">CEP</h4>
                                            <p className="list__item--info">{listaPaciente.cep}</p>
                                        </li>
                                        <li className="list__item">
                                            <h4 className="list__item--title">CPF</h4>
                                            <p className="list__item--info">{listaPaciente.cpf}</p>
                                        </li>
                                        <li className="list__item">
                                            <h4 className="list__item--title">RG</h4>
                                            <p className="list__item--info">{listaPaciente.rg}</p>
                                        </li>
                                        <li className="list__item">
                                            <h4 className="list__item--title">telefone</h4>
                                            <p className="list__item--info">{listaPaciente.telefone}</p>
                                        </li>
                                    </ul>
                                );
                            })
                        }
                    </div>
                </div>                     
            </section>
        );
    }


} 

export default ListarPaciente;