
import { Link } from 'react-router-dom';
import { parseJwt } from "../services/auth"

import "../assets/css/reset.css"
import "../assets/css/flexbox.css"
import "../assets/css/style.css"

import logo from "../assets/img/logo_spmedgroup_v1.png"

export default function header() {

    function Logout() {
        localStorage.removeItem('usuario-login')
    }

    return (
        <div>
            <header id="header" className="grid">
                <nav className="nav_header flex align_center space_between">

                    <Link to='/'><img className="logo_header" src={logo} alt="" /></Link>

                    <div className='container_header space_between'>
                        <ul className="ul_header flex align_center space_between">
                            <Link to='/listarConsultas'>
                                <li>consultas</li>
                            </Link>
                            {<Link to='/agendarConsulta'>
                                <li>cadastrar</li>
                            </Link>}
                            {parseJwt().role === '3' && <Link to='/'>
                                <li>medico</li>
                            </Link>}
                            {parseJwt().role === '1' && <li>paciente</li>}
                            <Link onClick={() => Logout()} to='/'>
                                <li>sair</li>
                            </Link>
                        </ul>
                    </div>

                </nav>
            </header>
        </div>
    )
}