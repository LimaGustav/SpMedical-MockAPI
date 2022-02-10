
import * as React from 'react';
import {usuarioAutenticado, parseJwt} from "../../services/auth"

import "../../assets/css/reset.css"
import "../../assets/css/flexbox.css"
import "../../assets/css/style.css"
import HeaderJS from "../../components/header"
import CardVerde from "../../components/cardVerde"
import ListarAdm from "../../components/consultasAdm"
import Listar from "../../components/consultas"


export default function ListarConsultas() {

    return (
        <div>
            <HeaderJS />
            <main className='column space_around'>
                <CardVerde />

                <Listar/>
            </main>
        </div>
    )
}