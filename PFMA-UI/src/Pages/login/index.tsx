
import { Button, FormControl, TextField } from '@mui/material'
import { ThemeProvider, useTheme } from '@mui/material'
import { MainTheme } from '../../Assests/custom-styles';
import './index.css'
import { useState } from 'react';
export default function Login() {
    const [signup, setSignup] = useState(true)

    const changeSignup = () => {
        setSignup(!signup)
    }
    return (
        <ThemeProvider theme={MainTheme}>
            <div className="main__container">
                <div className='image__container'>
                    <h4 className='hero__header'>AI is the paintbrush of the future, coloring our world with endless possibilities</h4>
                </div>
                <div className='form__container'>
                    <h4>PFMA</h4>
                    {signup ?
                        <div className='signin__container'>
                            <h3 className='main__header_text'>Secure Access to Your Financial Future</h3>
                            <p className='sub__heading'>Step into financial security with WealthWise. Log in now to access your wealth management tools.</p>
                            <FormControl sx={{ gap: 2 }}>
                                <TextField id="email" label="Email" variant="outlined" color="info" focused />
                                <TextField id="password" label="Password" variant="outlined" color="info" focused />
                                <p className='forget__link'>Forget Password?</p>
                                <Button color='primary' variant='contained'>Login</Button>
                                <p className='password__subline'>Don’t have an account ? <span className='password__subline_highlite' onClick={changeSignup}>Sign Up</span></p>
                            </FormControl>
                        </div>
                        :
                        <div className='signin__container'>
                            <h3 className='main__header_text'>Begin Your Journey to Financial Freedom</h3>
                            <p className='sub__heading'>Start Your Wealth Journey Now</p>
                            <FormControl sx={{ gap: 2 }}>
                                <TextField id="name" label="Name" variant="outlined" color="secondary" focused />
                                <TextField id="email" label="Email" variant="outlined" color="secondary" focused />
                                <TextField id="password" label="Password" variant="outlined" color="secondary" focused type='password' />
                                <TextField id="password" label="Confirm Password" variant="outlined" color="secondary" focused type='password' />
                                <Button color='primary' variant='contained'>Sign Up</Button>
                                <p>Already have an account ? <span className='password__subline_highlite' onClick={changeSignup}>Login</span></p>
                            </FormControl>
                        </div>
                    }
                </div>
            </div>
        </ThemeProvider>
    )
}