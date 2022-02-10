import { useState, useEffect } from "react";
import axios from 'axios';

import "../../assets/css/reset.css"
import "../../assets/css/flexbox.css"
import "../../assets/css/style.css"
import HeaderJS from "../../components/header"

import api from "../../services/api"

export default function CadastrarConsultas() {

    const [listaMedicos, setListaMedicos] = useState( [] );
    const [listaPacientes, setListaPacientes] = useState( [] );
    const [idPaciente, setIdPaciente] = useState(0);
    const [idMedico, setIdMedico] = useState(0);
    const [data, setData] = useState(new Date())

    function BuscarMedicos() {
        api.get('/Medicos', {
            headers : {
                'Authorization' : 'Bearer ' + localStorage.getItem('usuario-login')
            }
        })
        .then(response => {
            if (response.status === 200) {
                console.log('medicos buscados')
                setListaMedicos(response.data)
            }
        }).catch( erro => {
            console.log(erro)
        })
    }

    function BuscarPacientes() {
        api.get('/Pacientes', {
            headers : {
                'Authorization' : 'Bearer ' + localStorage.getItem('usuario-login')
            }
        })
        .then(response => {
            if (response.status === 200) {
                console.log('paciente buscados')
                setListaPacientes(response.data)
            }
        }).catch( erro => {
            console.log(erro)
        })
    }

    
    let consulta = {
        idPaciente : idPaciente,
        idMedico : idMedico,
        dataConsulta : data
    }


    function CadastrarConsutla(event) {
        event.preventDefault();
        api.post('/consultas', consulta,{
            headers : {
                'Authorization' : 'Bearer ' + localStorage.getItem('usuario-login')
            }
        })
        .then(response => {
            if (response.status === 201) {
                console.log('Consulta agendada')
                setIdPaciente(0);
                setData(new Date());
                setIdMedico(0)
            }
        }).catch(erro => {console.log(erro)})
    }

    useEffect(BuscarMedicos, [])
    useEffect(BuscarPacientes, [])

    return (
        <div>
            <HeaderJS />
            <main className="column space_around">
                <section id="agendar_card" class="grid section_agendar">
                    <div className="container_form justify_center">
                        <form onSubmit={CadastrarConsutla} class="column align_center space_evenly">

                            <div className="container_inputs column space_between align_center">

                                <select onChange={(campo) => setIdMedico(campo.target.value)}  value={idMedico}id='select_medico' name="medico">
                                    <option value="0">Selecione o médico</option>

                                    {listaMedicos.map(medico => {
                                        return (
                                            <option key={medico.idMedico} value={medico.idMedico}>{medico.nomeMedico}</option>
                                        )
                                    })}
                                </select>


                                <select onChange={(campo) => setIdPaciente(campo.target.value)} value={idPaciente} id='select_paciente' name="paciente">
                                    <option value="0">Selecione o paciente</option>
                                    {listaPacientes.map(paciente => {
                                        return (
                                            <option value={paciente.idPaciente}>{paciente.nomePaciente}</option>
                                        )
                                    })}
                                </select>


                                <input onChange={(campo) => setData(campo.target.value)} value={data} id='input_data' placeholder='Escolha da data' type="date" name=""/>
                            </div>

                            <button type="submit">Agendar</button>
                        </form>
                    </div>
                </section>
            </main>
        </div>
    )
}